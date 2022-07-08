using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class WorkSpaceModel:IWorkSpaceModel
{
    public Storage storage { get; set; }
    public Client clients { get; set; }
    
    
     
    public WorkSpaceModel()
    {
        
    }
}
