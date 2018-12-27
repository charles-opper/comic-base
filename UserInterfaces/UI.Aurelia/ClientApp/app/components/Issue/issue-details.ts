import { PublisherService } from "../Publisher/PublisherService";
import { inject } from "aurelia-framework";
import { Publisher } from "../Publisher/Models/Publisher";
import { IssueService } from "./IssueService";
import { Issue } from "./Models/Issue";
import { RouteConfig } from "aurelia-router";
import { EventAggregator } from "aurelia-event-aggregator";
import { IssueViewed, IssueUpdated } from "./Message";

@inject(IssueService, PublisherService, EventAggregator)
export class IssueDetails {

    constructor(issueService: IssueService, publisherService: PublisherService, eventAggregator: EventAggregator) {

        this.issueService = issueService;
        this.publisherService = publisherService;
        this.eventAggregator = eventAggregator;
        this.Publishers = [];

    }

    activate(params: any, routeConfig: RouteConfig) : any {

        this.routeConfig = routeConfig;

        this.publisherService.GetPublishers()
            .then(data => {
                this.Publishers = data;
            });

        this.newIssue = !params.id;
        if (!this.newIssue) {
            return this.issueService.GetIssueById(params.id).then(issue => {

                this.issue = <Issue>issue;
                this.routeConfig.navModel.setTitle(this.issue.Title);
                this.eventAggregator.publish(new IssueViewed(this.issue));

            });
        }
    }

    get canSave() {
        if (this.issue) {
            return this.issue.Title && this.issue.PublisherId && this.issue.Volume && this.issue.IssueNumber && this.issue.Year;
        }
        else {
            return false;
        }
    }

    save() {

        if (this.newIssue) {
            this.issueService.AddNew(this.issue).then(issue => {

                this.issue = <Issue>issue;

                this.eventAggregator.publish(new IssueUpdated(this.issue));

                if (this.routeConfig) {
                    this.routeConfig.navModel.setTitle(this.issue.Name);
                }

            });
        }
        else {
            this.issueService.Update(this.issue).then(issue => {

                this.issue = <Issue>issue;

                this.eventAggregator.publish(new IssueUpdated(this.issue));

                if (this.routeConfig) {
                    this.routeConfig.navModel.setTitle(this.issue.Name);
                }

            });
        }

    }

    public issue: Issue | any;
    public Publishers: Publisher[];

    private issueService: IssueService;
    private publisherService: PublisherService;
    private eventAggregator: EventAggregator;
    private routeConfig: RouteConfig | any;
    private newIssue: boolean = false;
}