import { Aurelia, PLATFORM } from 'aurelia-framework';
import { Router, RouterConfiguration } from 'aurelia-router';

export class App {
    router?: Router;

    configureRouter(config: RouterConfiguration, router: Router) {
        config.title = 'ComicBase';
        config.map([{
            route: [ '', 'home' ],
            name: 'home',
            settings: { icon: 'home' },
            moduleId: PLATFORM.moduleName('../home/home'),
            nav: true,
            title: 'Home'
        }, {
            route: 'issue',
            name: 'Issue',
            settings: { icon: 'education' },
            moduleId: PLATFORM.moduleName('../Issue/IssueComponent'),
            nav: true,
            title: 'My Issues'
        }, {
            route: 'fetch-data',
            name: 'fetchdata',
            settings: { icon: 'th-list' },
            moduleId: PLATFORM.moduleName('../fetchdata/fetchdata'),
            nav: true,
            title: 'Fetch data'
        }]);

        this.router = router;
    }
}
