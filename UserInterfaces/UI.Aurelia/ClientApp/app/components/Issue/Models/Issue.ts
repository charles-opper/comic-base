export class Issue {

    constructor(title: string, publisher: string, volume: number, issueNumber: number, year: number) {

        this.Title = title;
        this.Publisher = publisher;
        this.Volume = volume;
        this.IssueNumber = issueNumber;
        this.Year = year;

    }

    public Id?: number;
    public Title: string;
    public Publisher: string;
    public Volume: number;
    public IssueNumber: number;
    public Year: number;

}