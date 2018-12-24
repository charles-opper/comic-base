import { Issue } from "./Models/Issue";
import { IssueService } from "./IssueService";
import { inject } from "aurelia-framework";

@inject(IssueService)
export class IssueComponent {
    
    constructor(issueService: IssueService) {
        this.issueService = issueService;
    }

    attached() {

        this.Issues = this.issueService.GetIssues();

    }

    public Issues: Issue[] = [];
    protected issueService: IssueService;

}