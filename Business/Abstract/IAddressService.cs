using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IResult Add(IAddressService address);
    }
}
