import { Component, Inject, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'employee',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent {
  baseUrl = 'https://localhost:44336/api/Employee/';
  displayedColumns: string[] = ['id', 'firstName', 'lastName', 'email', 'gender', 'status'];
  dataSource = new MatTableDataSource<IEmployeeDto>();
  @ViewChild(MatPaginator, { static : true }) paginator: MatPaginator;

  constructor(public dialog: MatDialog, public http: HttpClient) {
    this.load();
  }

  load() {
    this.http.get<IEmployeeDto[]>(`${this.baseUrl}GetAll`).subscribe(result => {
      this.dataSource.data = result;
    }, error => console.error(error));
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    
  }

  delete() {
    alert('Not implemented!');
  }

  edit() {
    alert('Not implemented!');
  }
}

export interface IEmployeeDto {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  gender: string;
  status: boolean;
}

export class EmployeeDto implements IEmployeeDto {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  gender: string;
  status: boolean;
}
