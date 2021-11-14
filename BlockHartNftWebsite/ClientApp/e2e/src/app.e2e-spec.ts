// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

import { AppPage } from './app.po';

describe('BlockHartNftWebsite App', () => {
  let page: AppPage;

  beforeEach(() => {
    page = new AppPage();
  });

  it('should display application title: BlockHartNftWebsite', async () => {
    await page.navigateTo();
    expect(await page.getAppTitle()).toEqual('BlockHartNftWebsite');
  });
});
