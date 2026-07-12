using FluentValidation;

namespace Task_Management_System.DTOs
{
    public class CreateTaskDtoValidator : AbstractValidator<CreateTaskDto>
    {
        public CreateTaskDtoValidator() {

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(100).WithMessage("Title cannot exceed 10 characters.");

            RuleFor(x => x.Priority)
                .NotEmpty().WithMessage("Priority is required.")
                .Must(priority => priority == "Low" || priority == "Medium" || priority == "High")
                .WithMessage("Priority must be either 'Low', 'Medium', or 'High'.");

            RuleFor(x => x.DueDate)
                .GreaterThan(DateTime.Now).WithMessage("Due date must be in the future.");
        }
    }
}
