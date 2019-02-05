// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var root = Root.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Объект конфигурации
    /// </summary>
    public partial class Root
    {
        /// <summary>
        /// Добавляет в конфигурацию объекты из других конфигов
        /// </summary>
        [JsonProperty("$include", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Include { get; set; }

        [JsonProperty("$schema", NullValueHandling = NullValueHandling.Ignore)]
        public string Schema { get; set; }

        /// <summary>
        /// Описания деплоев
        /// </summary>
        [JsonProperty("Deployments", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Deployment> Deployments { get; set; }

        /// <summary>
        /// Значения параметров
        /// </summary>
        [JsonProperty("Parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Описания платформ
        /// </summary>
        [JsonProperty("Platforms", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, PlatformValue> Platforms { get; set; }

        /// <summary>
        /// Описания продуктов
        /// </summary>
        [JsonProperty("Products", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ProductValue> Products { get; set; }

        /// <summary>
        /// Описания тестов и групп
        /// </summary>
        [JsonProperty("Suites", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TestSuite> Suites { get; set; }

        /// <summary>
        /// Описания тестов и групп
        /// </summary>
        [JsonProperty("TestScenarios", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TestCase> TestScenarios { get; set; }

        /// <summary>
        /// Номер версии Starter/Warden, с которыми совместим конфиг
        /// </summary>
        [JsonProperty("version")]
        public long Version { get; set; }
    }

    /// <summary>
    /// Описание одного шага для подготовки тестового окружения. Может выполнять простые действия
    /// или вызывать другие шаги с определенными переменными
    /// </summary>
    public partial class Deployment
    {
        /// <summary>
        /// Выбор деплоя в зависимости от значения параметра
        ///
        /// Последовательность деплоев (для тестов compatibility)
        /// </summary>
        [JsonProperty("Type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("RebootExitCode", NullValueHandling = NullValueHandling.Ignore)]
        public long? RebootExitCode { get; set; }

        [JsonProperty("ReturnValue", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReturnValue { get; set; }

        [JsonProperty("ScriptArgs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> ScriptArgs { get; set; }

        [JsonProperty("ScriptPath", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptPath { get; set; }

        [JsonProperty("Timeout", NullValueHandling = NullValueHandling.Ignore)]
        public string Timeout { get; set; }

        [JsonProperty("RebootTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public string RebootTimeout { get; set; }

        [JsonProperty("Condition", NullValueHandling = NullValueHandling.Ignore)]
        public string Condition { get; set; }

        /// <summary>
        /// Должен ли выполняться тест, если значения параметра нет в списке? (для хотфиксов)
        /// </summary>
        [JsonProperty("SkipInvalidCondition", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipInvalidCondition { get; set; }

        [JsonProperty("Values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ValueValue> Values { get; set; }

        [JsonProperty("Deployments", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Deployments { get; set; }
    }

    public partial class PurpleDeployment
    {
        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProperties { get; set; }
    }

    public partial class ValueClass
    {
        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProperties { get; set; }
    }

    /// <summary>
    /// Описание конкретной версии ОС
    /// </summary>
    public partial class Platform
    {
    }

    /// <summary>
    /// Описание версии продукта
    /// </summary>
    public partial class Product
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Определения переменных, которые могут быть использованы в общих деплоях. Например, путь к
        /// инсталлятору и скрипту установки для деплоя 'Install Product'
        /// </summary>
        [JsonProperty("Parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Parameters { get; set; }

        [JsonProperty("ReleaseName")]
        public string ReleaseName { get; set; }

        [JsonProperty("Version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    /// <summary>
    /// Набор тестов, который можно запустить. Вычисляется декартово произведение {Platform} X
    /// {Product} Х {TestGroup}. Если тест или его деплой не поддерживают продукт и/или платформу
    /// то такие тесты будут пропущены с результатом Skipped. AdditionalDeployments выполняются
    /// перед всеми тестами
    /// </summary>
    public partial class TestSuite
    {
        [JsonProperty("Parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Parameters { get; set; }

        [JsonProperty("Platforms")]
        public string[] Platforms { get; set; }

        [JsonProperty("Products")]
        public string[] Products { get; set; }

        [JsonProperty("TestScenarios")]
        public string[] TestScenarios { get; set; }
    }

    public partial class TestGroup
    {
        [JsonProperty("TestScenarios", NullValueHandling = NullValueHandling.Ignore)]
        public string[] TestScenarios { get; set; }

        [JsonProperty("Area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        /// Необходимые тесту деплои. Будут выполнены в указанном порядке
        /// </summary>
        [JsonProperty("Deployments", NullValueHandling = NullValueHandling.Ignore)]
        public TestGroupDeployment[] Deployments { get; set; }

        /// <summary>
        /// Сочетания {продукты} x {платформы}, для которых поддерживается тест. Например, kes11 на
        /// серверах.
        /// </summary>
        [JsonProperty("Environments", NullValueHandling = NullValueHandling.Ignore)]
        public EnvironmentElement[] Environments { get; set; }

        /// <summary>
        /// Если true, то виндовый агент ставиться не будет
        /// </summary>
        [JsonProperty("NeedPythonAgent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedPythonAgent { get; set; }

        /// <summary>
        /// Аналог параметра сессии/деплоев unsignedAgent в Hive, отвечающий за то, нужен ли
        /// неподписанный агент для выполнения теста
        /// </summary>
        [JsonProperty("NeedUnsignedAgent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedUnsignedAgent { get; set; }

        /// <summary>
        /// Аналог WaitForNetwork - флаг, нужно ли тесту сначала дождаться установления соединения с
        /// интернетом
        /// </summary>
        [JsonProperty("RequireInternet", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireInternet { get; set; }

        /// <summary>
        /// Сколько раз перезапускать красный тест
        /// </summary>
        [JsonProperty("RerunCountOnTestFailure", NullValueHandling = NullValueHandling.Ignore)]
        public long? RerunCountOnTestFailure { get; set; }

        /// <summary>
        /// Сколько раз перезапускать зеленый тест
        /// </summary>
        [JsonProperty("RerunCountOnTestSuccess", NullValueHandling = NullValueHandling.Ignore)]
        public long? RerunCountOnTestSuccess { get; set; }

        [JsonProperty("Responsible", NullValueHandling = NullValueHandling.Ignore)]
        public string Responsible { get; set; }

        [JsonProperty("RevertAgentAfter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RevertAgentAfter { get; set; }

        [JsonProperty("RevertAgentBefore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RevertAgentBefore { get; set; }

        [JsonProperty("TestMethod", NullValueHandling = NullValueHandling.Ignore)]
        public TestMethod TestMethod { get; set; }

        [JsonProperty("TfsId", NullValueHandling = NullValueHandling.Ignore)]
        public long? TfsId { get; set; }

        /// <summary>
        /// Таймаут выполнения теста
        /// </summary>
        [JsonProperty("Timeout", NullValueHandling = NullValueHandling.Ignore)]
        public string Timeout { get; set; }

        [JsonProperty("UniqueId", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }

        [JsonProperty("MultiMachineId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MultiMachineId { get; set; }

        [JsonProperty("ProductGroupName", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ProductGroupName { get; set; }
    }

    public partial class FluffyDeployment
    {
        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProperties { get; set; }
    }

    public partial class EnvironmentElement
    {
        /// <summary>
        /// Список платформ (название отдельной платформы или заготовленного списка)
        /// </summary>
        [JsonProperty("Platforms")]
        public string[] Platforms { get; set; }

        /// <summary>
        /// Список продуктов (название отдельного продукта или заготовленного списка)
        /// </summary>
        [JsonProperty("Products")]
        public string[] Products { get; set; }
    }

    public partial class TestMethodEnvironment
    {
        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProperties { get; set; }
    }

    public partial class WaitForReboot
    {
        [JsonProperty("RebootTimeout", NullValueHandling = NullValueHandling.Ignore)]
        public string RebootTimeout { get; set; }
    }

    /// <summary>
    /// Выбор деплоя в зависимости от значения параметра
    ///
    /// Последовательность деплоев (для тестов compatibility)
    /// </summary>
    public enum TypeEnum { Script, Select, Sequence, Reboot };

    public partial struct DeploymentDeploymentUnion
    {
        public PurpleDeployment PurpleDeployment;
        public string String;

        public static implicit operator DeploymentDeploymentUnion(PurpleDeployment PurpleDeployment) => new DeploymentDeploymentUnion { PurpleDeployment = PurpleDeployment };
        public static implicit operator DeploymentDeploymentUnion(string String) => new DeploymentDeploymentUnion { String = String };
    }

    public partial struct ValueValue
    {
        public string String;
        public ValueClass ValueClass;

        public static implicit operator ValueValue(string String) => new ValueValue { String = String };
        public static implicit operator ValueValue(ValueClass ValueClass) => new ValueValue { ValueClass = ValueClass };
    }

    public partial struct PlatformValue
    {
        public Platform Platform;
        public string[] StringArray;

        public static implicit operator PlatformValue(Platform Platform) => new PlatformValue { Platform = Platform };
        public static implicit operator PlatformValue(string[] StringArray) => new PlatformValue { StringArray = StringArray };
    }

    public partial struct ProductValue
    {
        public Product Product;
        public string[] StringArray;

        public static implicit operator ProductValue(Product Product) => new ProductValue { Product = Product };
        public static implicit operator ProductValue(string[] StringArray) => new ProductValue { StringArray = StringArray };
    }

    public partial struct TestGroupDeployment
    {
        public FluffyDeployment FluffyDeployment;
        public string String;

        public static implicit operator TestGroupDeployment(FluffyDeployment FluffyDeployment) => new TestGroupDeployment { FluffyDeployment = FluffyDeployment };
        public static implicit operator TestGroupDeployment(string String) => new TestGroupDeployment { String = String };
    }

    public partial struct TestCase
    {
        public object[] AnythingArray;
        public bool? Bool;
        public double? Double;
        public long? Integer;
        public string String;
        public TestGroup TestGroup;

        public static implicit operator TestCase(object[] AnythingArray) => new TestCase { AnythingArray = AnythingArray };
        public static implicit operator TestCase(bool Bool) => new TestCase { Bool = Bool };
        public static implicit operator TestCase(double Double) => new TestCase { Double = Double };
        public static implicit operator TestCase(long Integer) => new TestCase { Integer = Integer };
        public static implicit operator TestCase(string String) => new TestCase { String = String };
        public static implicit operator TestCase(TestGroup TestGroup) => new TestCase { TestGroup = TestGroup };
        public bool IsNull => AnythingArray == null && Bool == null && TestGroup == null && Double == null && Integer == null && String == null;
    }

    public partial class Root
    {
        public static Root FromJson(string json) => JsonConvert.DeserializeObject<Root>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Root self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                DeploymentDeploymentUnionConverter.Singleton,
                TypeEnumConverter.Singleton,
                ValueValueConverter.Singleton,
                PlatformValueConverter.Singleton,
                ProductValueConverter.Singleton,
                TestCaseConverter.Singleton,
                TestGroupDeploymentConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class DeploymentDeploymentUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DeploymentDeploymentUnion) || t == typeof(DeploymentDeploymentUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new DeploymentDeploymentUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleDeployment>(reader);
                    return new DeploymentDeploymentUnion { PurpleDeployment = objectValue };
            }
            throw new Exception("Cannot unmarshal type DeploymentDeploymentUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DeploymentDeploymentUnion)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.PurpleDeployment != null)
            {
                serializer.Serialize(writer, value.PurpleDeployment);
                return;
            }
            throw new Exception("Cannot marshal type DeploymentDeploymentUnion");
        }

        public static readonly DeploymentDeploymentUnionConverter Singleton = new DeploymentDeploymentUnionConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Script":
                    return TypeEnum.Script;
                case "Select":
                    return TypeEnum.Select;
                case "Sequence":
                    return TypeEnum.Sequence;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Script:
                    serializer.Serialize(writer, "Script");
                    return;
                case TypeEnum.Select:
                    serializer.Serialize(writer, "Select");
                    return;
                case TypeEnum.Sequence:
                    serializer.Serialize(writer, "Sequence");
                    return;
                case TypeEnum.Reboot:
                    serializer.Serialize(writer, "Reboot");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class ValueValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueValue) || t == typeof(ValueValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ValueValue { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ValueClass>(reader);
                    return new ValueValue { ValueClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type ValueValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ValueValue)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ValueClass != null)
            {
                serializer.Serialize(writer, value.ValueClass);
                return;
            }
            throw new Exception("Cannot marshal type ValueValue");
        }

        public static readonly ValueValueConverter Singleton = new ValueValueConverter();
    }

    internal class PlatformValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PlatformValue) || t == typeof(PlatformValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Platform>(reader);
                    return new PlatformValue { Platform = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<string[]>(reader);
                    return new PlatformValue { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PlatformValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PlatformValue)untypedValue;
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            if (value.Platform != null)
            {
                serializer.Serialize(writer, value.Platform);
                return;
            }
            throw new Exception("Cannot marshal type PlatformValue");
        }

        public static readonly PlatformValueConverter Singleton = new PlatformValueConverter();
    }

    internal class ProductValueConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProductValue) || t == typeof(ProductValue?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Product>(reader);
                    return new ProductValue { Product = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<string[]>(reader);
                    return new ProductValue { StringArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ProductValue");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ProductValue)untypedValue;
            if (value.StringArray != null)
            {
                serializer.Serialize(writer, value.StringArray);
                return;
            }
            if (value.Product != null)
            {
                serializer.Serialize(writer, value.Product);
                return;
            }
            throw new Exception("Cannot marshal type ProductValue");
        }

        public static readonly ProductValueConverter Singleton = new ProductValueConverter();
    }

    internal class TestCaseConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TestCase) || t == typeof(TestCase?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new TestCase { };
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new TestCase { Integer = integerValue };
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new TestCase { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new TestCase { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new TestCase { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TestGroup>(reader);
                    return new TestCase { TestGroup = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<object[]>(reader);
                    return new TestCase { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TestCase");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TestCase)untypedValue;
            if (value.IsNull)
            {
                serializer.Serialize(writer, null);
                return;
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.TestGroup != null)
            {
                serializer.Serialize(writer, value.TestGroup);
                return;
            }
            throw new Exception("Cannot marshal type TestCase");
        }

        public static readonly TestCaseConverter Singleton = new TestCaseConverter();
    }

    internal class TestGroupDeploymentConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TestGroupDeployment) || t == typeof(TestGroupDeployment?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new TestGroupDeployment { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyDeployment>(reader);
                    return new TestGroupDeployment { FluffyDeployment = objectValue };
            }
            throw new Exception("Cannot unmarshal type TestGroupDeployment");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TestGroupDeployment)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.FluffyDeployment != null)
            {
                serializer.Serialize(writer, value.FluffyDeployment);
                return;
            }
            throw new Exception("Cannot marshal type TestGroupDeployment");
        }

        public static readonly TestGroupDeploymentConverter Singleton = new TestGroupDeploymentConverter();
    }
}
