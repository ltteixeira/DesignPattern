using CommandPattern.fx;

namespace CommandPattern
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService _service;

        public AddCustomerCommand(CustomerService customerService)
        {
            _service = customerService;
        }

        public void execute() => _service.addCustomer();
    }
}
