// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Signing happens in MSBuild")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.Operation.#Security", Justification = "This type is strictly a serialization model.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.ServiceDefinition.#Paths", Justification = "This type is strictly a serialization model.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.ServiceDefinition.#Security", Justification = "This type is strictly a serialization model.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.OperationBuilder.#BuildMethod(Microsoft.Rest.Generator.ClientModel.HttpMethod,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.SwaggerModeler.#BuildMethod(Microsoft.Rest.Generator.ClientModel.HttpMethod,System.String,System.String,Microsoft.Rest.Modeler.Swagger.Model.Operation)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.SwaggerModeler.#BuildMethodBaseUrl(Microsoft.Rest.Generator.ClientModel.ServiceClient,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.Contact.#Url")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.ExternalDoc.#Url")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.License.#Url")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.SecurityDefinition.#AuthorizationUrl")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.SecurityDefinition.#TokenUrl")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Extensions.#ToHttpMethod(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Logging.ErrorManager.CreateError(System.String,System.Object[])", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.SwaggerParser.#Parse(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Extensions.#ToHttpMethod(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.SchemaResolver.#Dereference(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.SwaggerModeler.#InitializeClientModel()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.OperationBuilder.#BuildMethod(Microsoft.Rest.Generator.ClientModel.HttpMethod,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "param", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.CollectionFormatBuilder.#OnBuildMethodParameter(Microsoft.Rest.Generator.ClientModel.Method,Microsoft.Rest.Modeler.Swagger.Model.SwaggerParameter,System.Text.StringBuilder)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Param", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.CollectionFormatBuilder.#OnBuildMethodParameter(Microsoft.Rest.Generator.ClientModel.Method,Microsoft.Rest.Modeler.Swagger.Model.SwaggerParameter,System.Text.StringBuilder)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "OAuth", Scope = "type", Target = "Microsoft.Rest.Modeler.Swagger.Model.OAuthFlow")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "OAuth", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.SecuritySchemeType.#OAuth2")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Ws", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.TransferProtocolScheme.#Ws")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Wss", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.TransferProtocolScheme.#Wss")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Ws", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.TransferProtocolScheme.#Ws")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Default", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.SwaggerObject.#Default")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Enum", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.SwaggerObject.#Enum")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.SwaggerObject.#Type")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Microsoft.Rest.Modeler.Swagger.Model.Schema")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.Model.SwaggerObject.#GetBuilder(Microsoft.Rest.Modeler.Swagger.SwaggerModeler)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "operation", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.OperationBuilder.#SwaggerOperationProducesJson(Microsoft.Rest.Modeler.Swagger.Model.Operation)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "operation", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.OperationBuilder.#SwaggerOperationConsumesJson(Microsoft.Rest.Modeler.Swagger.Model.Operation)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "operation", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.OperationBuilder.#SwaggerOperationProducesOctetStream(Microsoft.Rest.Modeler.Swagger.Model.Operation)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "operation", Scope = "member", Target = "Microsoft.Rest.Modeler.Swagger.OperationBuilder.#SwaggerOperationConsumesMultipartFormData(Microsoft.Rest.Modeler.Swagger.Model.Operation)")]
