using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IResult Insert(Address address);
        IResult Update(Address address);
        IDataResult<List<Address>> GetAll();
        
            
       
    }
}
