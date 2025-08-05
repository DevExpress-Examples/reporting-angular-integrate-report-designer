import { test, expect } from '@playwright/test';

test('homepage should load', async ({ page }) => {
    console.log('Starting Playwright test for homepage');
  await page.goto('http://localhost:4200'); // adjust if your Angular app runs on another port

  // Sample assertion: check if title contains Angular
  await expect(page).toHaveTitle(/AngularReportDesigner/i);

  // You can also assert DOM content
  await expect(page.locator('h1')).toContainText('Welcome');
});
