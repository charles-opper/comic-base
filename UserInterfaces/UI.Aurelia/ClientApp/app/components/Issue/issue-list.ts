import { Issue } from "./Models/Issue";
import { IssueService } from "./IssueService";
import { inject } from "aurelia-framework";
import { BindingSignaler } from "aurelia-templating-resources";
import { EventAggregator } from "aurelia-event-aggregator";
import { IssueViewed, IssueUpdated, IssueDeleted } from "./Message";

@inject(IssueService, EventAggregator, BindingSignaler)
export class IssueList {

    constructor(issueService: IssueService, eventAggregator: EventAggregator, signaler: BindingSignaler) {

        this.issueService = issueService;
        this.eventAggregator = eventAggregator;
        this.signaler = signaler;

        this.eventAggregator.subscribe(IssueViewed, (msg: IssueViewed) => this.select(msg.issue));

        this.eventAggregator.subscribe(IssueUpdated, (msg: IssueUpdated) => {
            let id = msg.issue.Id;
            let found = this.Issues.find(i => i.Id == id);
            if (found) {
                Object.assign(found, msg.issue);
            } else {
                this.Issues.push(msg.issue);
                this.signaler.signal('list-refresh');
            }
        });

        this.eventAggregator.subscribe(IssueDeleted, (msg: IssueDeleted) => {

            let idx = this.Issues.findIndex(i => i.Id == msg.id);
            if (idx > -1) {
                this.Issues.splice(idx, 1);
                this.signaler.signal('list-refresh');
            }

        });

    }

    created() {

        this.issueService.GetIssues()
            .then(data => {
                this.Issues = data;
            });

    }

    public select(issue: Issue) {

        this.SelectedId = issue.Id;

        return true;
    }

    public remove(id: number) {

        this.issueService.Remove(id);
        this.eventAggregator.publish(new IssueDeleted(id));

    }

    public filter() {

        let filter = this.titleFilter && this.titleFilter.length > 0 ? this.titleFilter : "";
        if (filter) {
            this.Issues = this.Issues.filter(f => f.Title.indexOf(filter) > -1);
        }

        filter = this.publisherFilter && this.publisherFilter.length > 0 ? this.publisherFilter : "";
        if (filter) {
            this.Issues = this.Issues.filter(f => f.Publisher.Name.indexOf(filter) > -1);
        }

        if (this.volumeFilter && this.volumeFilter > 0) {
            this.Issues = this.Issues.filter(f => f.Volume == this.volumeFilter);
        }

        if (this.issueNumberFilter && this.issueNumberFilter > 0) {
            this.Issues = this.Issues.filter(f => f.IssueNumber == this.issueNumberFilter);
        }

        if (this.yearFilter && this.yearFilter > 0) {
            this.Issues = this.Issues.filter(f => f.Year == this.yearFilter);
        }

        this.signaler.signal('list-refresh');

    }

    public clearFilter() {

        this.titleFilter = undefined;
        this.publisherFilter = undefined;
        this.volumeFilter = undefined;
        this.issueNumberFilter = undefined;
        this.yearFilter = undefined;

        this.fetchIssues();

        this.signaler.signal('list-refresh');

    }

    private fetchIssues() {

        this.issueService.GetIssues()
            .then(data => {
                this.Issues = data;
            });

    }

    public titleFilter?: string;
    public publisherFilter?: string;
    public volumeFilter?: number;
    public issueNumberFilter?: number;
    public yearFilter?: number;

    public SelectedId?: number;

    public Issues: Issue[] = [];

    private issueService: IssueService;
    private eventAggregator: EventAggregator;
    private signaler: BindingSignaler;

}