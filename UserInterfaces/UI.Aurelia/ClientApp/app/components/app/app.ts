import { Aurelia, PLATFORM } from 'aurelia-framework';
import { Router, RouterConfiguration } from 'aurelia-router';

export class App {
    router?: Router;

    configureRouter(config: RouterConfiguration, router: Router) {

        config.title = 'Comic Base';
        config.map([
            { route: '', moduleId: PLATFORM.moduleName('../issue/no-selection'), title: 'Select Issue' },
            { route: 'issues/:id?', moduleId: PLATFORM.moduleName('../issue/issue-details'), name: 'issues' }
        ]);

        config.fallbackRoute('');

        this.router = router;
    }
}
