import { Issue } from "./Models/Issue";

export class IssueUpdated {
    constructor(public issue: Issue) { }
}

export class IssueViewed {
    constructor(public issue: Issue) { }
}

export class IssueDeleted {
    constructor(public id: number) { }
}