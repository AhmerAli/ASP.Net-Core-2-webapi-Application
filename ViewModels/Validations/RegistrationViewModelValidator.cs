using FluentValidation;
 

namespace server.ViewModels.Validations
{
    public class RegistrationViewModelValidator : AbstractValidator<RegistrationViewModel>
    {
        public RegistrationViewModelValidator()
        {
            RuleFor(vm => vm.Email).NotEmpty().WithMessage("Email cannot be empty");
            RuleFor(vm => vm.Password).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(vm => vm.Employee_ID).NotEmpty().WithMessage("EmployeeID cannot be empty");
            RuleFor(vm => vm.First_Name).NotEmpty().WithMessage("First Name cannot be empty");
            RuleFor(vm => vm.Last_Name).NotEmpty().WithMessage("Last Name cannot be empty");
            RuleFor(vm => vm.City).NotEmpty().WithMessage("City cannot be empty");
            RuleFor(vm => vm.Address_1).NotEmpty().WithMessage("Address 1 cannot be empty");
            RuleFor(vm => vm.Contact_No).NotEmpty().WithMessage("Contact No cannot be empty");
        }
    }
}