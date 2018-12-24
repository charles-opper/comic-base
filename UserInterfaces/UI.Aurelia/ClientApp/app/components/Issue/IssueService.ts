import { Issue } from "./Models/Issue";

export class IssueService {

    public GetIssues(): Issue[] {

        let issues: Issue[] = [];

        issues.push(new Issue("X-Men", "Marvel", 1, 1, 1963));

        return issues;

    }

}