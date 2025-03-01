import { Component, OnInit } from '@angular/core';
import { MasterService } from '../../service/master.service';
import { inject } from '@angular/core';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-enquiry-list',
  imports: [DatePipe],
  templateUrl: './enquiry-list.component.html',
  styleUrl: './enquiry-list.component.css'
})
export class EnquiryListComponent implements OnInit {

  masterSrv = inject(MasterService);
  enquiryList: any [] = [];

  ngOnInit(): void {
    this.masterSrv.getAllEnquiry().subscribe((res: any) => {
      this.enquiryList = res;
    });
  }

}



