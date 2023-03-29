using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace efcore_7._0._4;

public class IssueRelationalModelValidator : RelationalModelValidator // IModelValidator
{
    public IssueRelationalModelValidator(ModelValidatorDependencies dependencies, RelationalModelValidatorDependencies relationalDependencies) : base(dependencies, relationalDependencies)
    {
    }

    public override void Validate(IModel model, IDiagnosticsLogger<DbLoggerCategory.Model.Validation> logger)
    {
        base.Validate(model, logger); // Causes the issue

        foreach (var property in model.GetEntityTypes().SelectMany(t => t.GetDeclaredProperties()).Where(p => p.Name == "Weight").OfType<IConventionProperty>())
        {
            var configurationSource = property.GetColumnTypeConfigurationSource();

            Console.WriteLine($"Property {property.Name} with ClrType {property.ClrType}");
            Console.WriteLine($"    Overrides TypeMapping {ConfigurationSource.Convention.Overrides(property.GetTypeMappingConfigurationSource())}");
            Console.WriteLine($"    Overrides ConfigurationSource {ConfigurationSource.Convention.Overrides(configurationSource)}");
            Console.WriteLine($"    Overrides Precision {ConfigurationSource.Convention.Overrides(property.GetPrecisionConfigurationSource())}");
            Console.WriteLine($"    Overrides Scale {ConfigurationSource.Convention.Overrides(property.GetScaleConfigurationSource())}");
        }
    }
}