# Requires -Version 7

Set-StrictMode -Version latest
$ErrorActionPreference = 'Stop'

function CheckLastExitCode() {
    if ($LastExitCode -ne 0) {
        Write-Error -ErrorAction Stop "Last exit code: $LastExitCode"
    }
}

function InstallNpmPackages() {
    if(-Not(Test-Path .\node_modules\*)) {
        npm ci | Out-Host
        CheckLastExitCode
    }
}

function LaunchBackend([Parameter(Mandatory)][string]$path) {
    Push-Location $path
    try {
        Write-Host "Starting backend server..."
        $process = Start-Process dotnet -ArgumentList ('run') -PassThru
        Start-Sleep -Seconds 15  # Give backend time to start (increased from 5 to match frontend timing)
        return $process
    } finally {
        Pop-Location
    }
}

function LaunchFrontend([Parameter(Mandatory)][string]$path) {
    Push-Location $path
    try {
        InstallNpmPackages
        Write-Host "Starting frontend server..."
        $process = Start-Process cmd -ArgumentList ('/c', 'npm', 'start') -PassThru
        Write-Host "Waiting for frontend to be ready..."
        Start-Sleep -Seconds 5  # Give frontend time to build and start
        return $process
    } finally {
        Pop-Location
    }
}

function RunTestCafeTests() {
    $browserList = if ($env:BROWSER) { $env:BROWSER } else { 'chrome' }
    $fileOrGlob = './test/testcafe-test.ts'

    $arguments = @(
        '/c'
        'npx.cmd'
        'testcafe'
        $browserList
        $fileOrGlob
        '--base-url http://localhost:4200'
        '--selector-timeout 1000'
        '--assertion-timeout 1000'
    )

    $process = Start-Process 'cmd' -ArgumentList $arguments -NoNewWindow -Wait -ErrorAction Stop -PassThru
    $exitCode = $process.ExitCode

    Write-Host "TestCafe exit code: $exitCode"
    return $exitCode
}

function Main() {
    InstallNpmPackages
    Write-Host "Launching backend..."
    $backendProcess = LaunchBackend ./ServerApp
    try {
        Write-Host "Launching frontend..."
        $frontendProcess = LaunchFrontend ./angular-report-designer
        try {
            Write-Host "Running TestCafe tests..."
            return RunTestCafeTests
        } finally {
            Write-Host "Stopping frontend process..."
            taskkill.exe /F /T /PID $frontendProcess.Id | Out-Host
            Write-Host "Frontend process is stopped"
        }
    } finally {
        Stop-Process $backendProcess | Out-Host
        Write-Host "Backend process is stopped"
    }
}

try {
    Exit [int](Main)
} catch {
    Write-Host -ForegroundColor Red $_.Exception
    $_.ScriptStackTrace -split [System.Environment]::NewLine | ForEach-Object { Write-Host -ForegroundColor Red "  $_" }
    Exit -1
}
