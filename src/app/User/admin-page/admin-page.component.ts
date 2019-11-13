import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatTableDataSource } from '@angular/material';
import { AdminService } from 'src/app/Service/admin.service';
import { UserService } from 'src/app/Service/user.service';

@Component({
  selector: 'app-admin-page',
  templateUrl: './admin-page.component.html',
  styleUrls: ['./admin-page.component.scss']
})
export class AdminPageComponent implements OnInit {
  displayedColumns: string[] = ['index', 'email', 'loginTime', 'service'];
  displayUserColumns: string[] = ['firstName', 'lastName', 'email', 'cardType', 'totalNotes', 'status'];
  elements = [];
  users = [];
  index = 1;
  dataSource;
  userdataSource;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatPaginator) pagin: MatPaginator;
  constructor(private adminService: AdminService,
    private userService: UserService) { }

  ngOnInit() {
    this.adminService.userStatic().subscribe((data: any) => {
      this.elements = data;
      this.dataSource = new MatTableDataSource(this.elements);
      this.index = 1;
      this.dataSource.paginator = this.paginator;
    });
    this.userService.userList().subscribe((data: any) => {
      this.users = data;
      this.userdataSource = new MatTableDataSource(this.users);
      this.userdataSource.pagin = this.pagin;
    });
  }
}
