import { Issue } from "./Models/Issue";
import { HttpClient } from "aurelia-fetch-client";
import { inject } from "aurelia-framework";

@inject(HttpClient)
export class IssueService {

    constructor(httpClient: HttpClient) {
        this._httpClient = httpClient;
    }

    public async GetIssues(): Promise<Issue[]> {

        let issues: Issue[] = [];

        await this._httpClient.fetch('api/issue')
            .then(result => result.json() as Promise<Issue[]>)
            .then(data => {
                issues = data;
            })
            .catch(function (err) {
                console.log('Error: ${err}');
            });

        return issues;

    }

    public async GetIssueById(id: number): Promise<Issue> {

        let issue: Issue | any;

        await this._httpClient.fetch('api/issue/' + id)
            .then(result => result.json() as Promise<Issue>)
            .then(data => {
                issue = data;
            })
            .catch(function (err) {
                console.log('Error: ${err}');
            });

        return issue;
    }

    public async AddNew(issue: Issue): Promise<Issue> {

        let newIssue: Issue | any;

        await this._httpClient.fetch("api/issue",
            {
                method: "POST",
                body: JSON.stringify(issue),
                headers: {
                    "Content-Type": "application/json",
                    "Accept": "application/json"
                }
            })
            .then(result => result.json() as Promise<Issue>)
            .then(data => {
                newIssue = data;
            })
            .catch(function (err) {
                console.log('Error: ${err}');
            });

        return newIssue;
    }

    public async Update(issue: Issue): Promise<Issue> {

        await this._httpClient.fetch("api/issue/" + issue.Id,
            {
                method: "PUT",
                body: JSON.stringify(issue),
                headers: {
                    "Content-Type": "application/json",
                    "Accept": "application/json"
                }
            })
            .catch(function (err) {
                console.log('Error: ${err}');
            });

        return issue;
    }

    public Remove(id: number): void {

        this._httpClient.fetch("api/issue/" + id,
            {
                method: "DELETE",
                headers: {
                    "Content-Type": "application/json",
                    "Accept": "application/json"
                }
            })
            .catch(function (err) {
                console.log('Error: ${err}');
            });

    }

    private _httpClient: HttpClient;
}