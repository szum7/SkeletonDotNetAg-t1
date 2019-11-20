import { Component } from '@angular/core';
import { TestTableService } from '../../services/test-table-service/test-table.service';

@Component({
    selector: 'app-transactions-page',
    templateUrl: './transactions.page.html',
    styleUrls: ['./transactions.page.scss']
})
export class TestTablePage {

    constructor(private testTableService: TestTableService) {
    }

    public get(): void {
        this.testTableService.get().subscribe((response) => {
            console.log(response);
        }, (error) => {
            console.log(error);
        });
    }

    public testCall(): void {
        this.testTableService.testCall().subscribe((response) => {
            console.log(response);
        }, (error) => {
            console.log(error);
        });
    }
}
