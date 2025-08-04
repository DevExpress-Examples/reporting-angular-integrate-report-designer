import { Selector } from 'testcafe';
import { assertUntilCondition, designerMenuButton, getMenuItemByText, getToolbarButtonByText } from '@devexpress/reporting-testcafe-helpers/units';
import { checkPreviewPage } from '@devexpress/reporting-testcafe-helpers/preview';

fixture('Maximize window')
    .beforeEach(async t => {
        await t.maximizeWindow();
    });


test('Check whether Report Designer is rendered', async t => {
    const reportDesigner = Selector('app-root div dx-report-designer');
    await t.expect(reportDesigner.exists).ok('DevExpress Report Designer should exist');
});
test('Check simple UI actions in Report Designer', async t => {
    await assertUntilCondition(t, () => getToolbarButtonByText('preview').exists, 'Wait for designer loading');
    await t
        .dispatchEvent(getToolbarButtonByText('preview'), 'click');
    await checkPreviewPage(t, 15);
    await t
        .dispatchEvent(getToolbarButtonByText('design'), 'click')
        .click(designerMenuButton)
        .click(getMenuItemByText('Exit'));
});