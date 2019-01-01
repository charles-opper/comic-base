import { Aurelia, PLATFORM } from 'aurelia-framework';
import { Router, RouterConfiguration } from 'aurelia-router';

export class App {
    router?: Router;

    configureRouter(config: RouterConfiguration, router: Router) {

        config.title = 'Comic Base';
        config.map([
            { route: '', redirect: 'issuemanager' },
            { route: 'issuelist', moduleId: PLATFORM.moduleName('../issue/issue-list'), name: 'issuelist' },
            { route: 'issues/:id?', moduleId: PLATFORM.moduleName('../issue/issue-details'), name: 'issues' },
            { route: 'issuemanager', moduleId: PLATFORM.moduleName('../issue/issue-manager'), name: 'issuemanager', title: 'My Issues', nav: true },
            { route: 'cosmicsearch', moduleId: PLATFORM.moduleName('../cosmicsearch/cosmic-search'), name: 'cosmicsearch', title: 'Cosmic Search', nav: true }
        ]);

        config.fallbackRoute('');

        this.router = router;
    }
}
