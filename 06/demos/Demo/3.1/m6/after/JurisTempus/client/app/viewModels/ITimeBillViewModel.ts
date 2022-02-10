export interface ITimeBillViewModel {
  id: number;
  workDate: Date;
  timeSegments: number;
  rate: number;
  workDescription: string;
  employeeId: number;
  caseId: number;
}
