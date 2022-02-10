import { Component, OnInit } from '@angular/core';
import { DataService } from './services/DataService';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ITimeBillViewModel } from './viewModels/ITimeBillViewModel';

@Component({ 
  selector: 'theApp',
  templateUrl: './app.component.html', 
  styleUrls: ['./app.component.css']
}) 
export class AppComponent implements OnInit {
  theForm: FormGroup;
  employee: string = "Shawn Wildermuth";
  employeeId: number = 1;
  message: string = "";
  cases = [
    {
      id: 1, 
      fileNumber: "12345",
      client: "Jones, M."
    },
    {
      id: 2,
      fileNumber: "1235",
      client: "Smith, J."
    },
  ];

  constructor(private _formBldr: FormBuilder, private _dataService: DataService) {  
  }

  ngOnInit(): void {
    this.theForm = this._formBldr.group({
      caseId: [0, Validators.required],
      workDate: [new Date()], 
      timeSegments: [0, [Validators.required, Validators.max(72)]],
      rate: [120.00, [Validators.required, Validators.min(85), Validators.max(1000)]],
      workDescription: ["", [Validators.required, Validators.maxLength(4000), Validators.minLength(25)]]
    });
  }

  save() {
    let timeBill: ITimeBillViewModel = this.theForm.value;
    timeBill.employeeId = this.employeeId;
    this._dataService.saveTimesheet(timeBill);
    this.message = "Saved...";
  }
}
