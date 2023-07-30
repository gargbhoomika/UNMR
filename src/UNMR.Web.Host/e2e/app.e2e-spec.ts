import { UNMRTemplatePage } from './app.po';

describe('UNMR App', function() {
  let page: UNMRTemplatePage;

  beforeEach(() => {
    page = new UNMRTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
