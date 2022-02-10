using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurisTempus.ViewModels
{
  public class TimeBillViewModel
  {
    public int Id { get; set; }
    public DateTime WorkDate { get; set; }
    public int TimeSegments { get; set; }
    public decimal Rate { get; set; }
    public string WorkDescription { get; set; }

    public int EmployeeId { get; set; }
    public int CaseId { get; set; }

  }
}
