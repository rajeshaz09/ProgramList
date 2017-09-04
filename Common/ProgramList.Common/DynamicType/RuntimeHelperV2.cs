using ProgramList.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
namespace ProgramList.Common.DynamicType
{
    public static class RunTimeTypeHelperV2
    {
        private static Type _baseClassType;
        private static Type[] _baseInterfaceTypeList;
        private static Type[] ConstructorParameterTypeList;
        private static ConstructorInfo _baseClassConstructorInfo;

        private static Type[] _stringType = new Type[] { typeof(string) };
        private static Type[] _intType = new Type[] { typeof(int) };
        private static Type[] _boolType = new Type[] { typeof(bool) };
        private static Type[] _datetimeType = new Type[] { typeof(DateTime?) };
        private static Type[] _chartType = new Type[] { typeof(ChartPointCollection) };

        private static MethodInfo _extensionPropertyGetter;
        private static MethodInfo _extensionPropertySetter;
        private static MethodInfo _instancePropertySetter;

        private static MethodInfo _stringExtensionPropertyGetter;
        private static MethodInfo _stringExtensionPropertySetter;
        private static MethodInfo _stringInstancePropertySetter;

        private static MethodInfo _intExtensionPropertyGetter;
        private static MethodInfo _intExtensionPropertySetter;
        private static MethodInfo _intInstancePropertySetter;

        private static MethodInfo _boolExtensionPropertyGetter;
        private static MethodInfo _boolExtensionPropertySetter;
        private static MethodInfo _boolInstancePropertySetter;

        private static MethodInfo _datetimeExtensionPropertyGetter;
        private static MethodInfo _datetimeExtensionPropertySetter;
        private static MethodInfo _datetimeInstancePropertySetter;

        private static MethodInfo _chartExtensionPropertyGetter;
        private static MethodInfo _chartExtensionPropertySetter;
        private static MethodInfo _chartInstancePropertySetter;




        private static MethodInfo _foregroundGetter;
        private static MethodInfo _foregroundSetter;

        private static MethodInfo _backgroundGetter;
        private static MethodInfo _backgroundSetter;

        private static MethodInfo _isEnabledGetter;
        private static MethodInfo _isEnabledSetter;

        private static MethodInfo _isReadOnlyGetter;
        private static MethodInfo _isReadOnlySetter;

        private static MethodInfo _isInEditModeGetter;
        private static MethodInfo _isInEditModeSetter;

        private static MethodInfo _isCurrentGetter;
        private static MethodInfo _isCurrentSetter;

        static RunTimeTypeHelperV2()
        {


            _baseClassType = typeof(ListItemBase);
            _baseInterfaceTypeList = new Type[] { typeof(INotifyPropertyChanged) };
            ConstructorParameterTypeList = new Type[] { typeof(IList<IColumnInfo>), _intType[0] };
            _baseClassConstructorInfo = _baseClassType.GetConstructor(ConstructorParameterTypeList);


            var runtimeModelBaseType = typeof(RunTimeModelBase);
            var publicOrProtectedFlags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
            _extensionPropertyGetter = runtimeModelBaseType.GetMethod("GetValue", publicOrProtectedFlags);
            _extensionPropertySetter = runtimeModelBaseType.GetMethod("SetValue", publicOrProtectedFlags);
            _instancePropertySetter = runtimeModelBaseType.GetMethod("SetProperty", publicOrProtectedFlags);

            _stringExtensionPropertyGetter = _extensionPropertyGetter.MakeGenericMethod(_stringType);
            _stringExtensionPropertySetter = _extensionPropertySetter.MakeGenericMethod(_stringType);
            _stringInstancePropertySetter = _instancePropertySetter.MakeGenericMethod(_stringType);

            _intExtensionPropertyGetter = _extensionPropertyGetter.MakeGenericMethod(_intType);
            _intExtensionPropertySetter = _extensionPropertySetter.MakeGenericMethod(_intType);
            _intInstancePropertySetter = _instancePropertySetter.MakeGenericMethod(_intType);

            _boolExtensionPropertyGetter = _extensionPropertyGetter.MakeGenericMethod(_boolType);
            _boolExtensionPropertySetter = _extensionPropertySetter.MakeGenericMethod(_boolType);
            _boolInstancePropertySetter = _instancePropertySetter.MakeGenericMethod(_boolType);

            _datetimeExtensionPropertyGetter = _extensionPropertyGetter.MakeGenericMethod(_datetimeType);
            _datetimeExtensionPropertySetter = _extensionPropertySetter.MakeGenericMethod(_datetimeType);
            _datetimeInstancePropertySetter = _instancePropertySetter.MakeGenericMethod(_datetimeType);

            _chartExtensionPropertyGetter = _extensionPropertyGetter.MakeGenericMethod(_chartType);
            _chartExtensionPropertySetter = _extensionPropertySetter.MakeGenericMethod(_chartType);
            _chartInstancePropertySetter = _instancePropertySetter.MakeGenericMethod(_chartType);

            _foregroundGetter = _baseClassType.GetMethod("GetForegroundInternal", publicOrProtectedFlags);
            _foregroundSetter = _baseClassType.GetMethod("SetForegroundInternal", publicOrProtectedFlags);

            _backgroundGetter = _baseClassType.GetMethod("GetBackgroundInternal", publicOrProtectedFlags);
            _backgroundSetter = _baseClassType.GetMethod("SetBackgroundInternal", publicOrProtectedFlags);

            _isEnabledGetter = _baseClassType.GetMethod("GetIsEnabledInternal", publicOrProtectedFlags);
            _isEnabledSetter = _baseClassType.GetMethod("SetIsEnabledInternal", publicOrProtectedFlags);

            _isReadOnlyGetter = _baseClassType.GetMethod("GetIsReadOnlyInternal", publicOrProtectedFlags);
            _isReadOnlySetter = _baseClassType.GetMethod("SetIsReadOnlyInternal", publicOrProtectedFlags);

            _isInEditModeGetter = _baseClassType.GetMethod("GetIsInEditModeInternal", publicOrProtectedFlags);
            _isInEditModeSetter = _baseClassType.GetMethod("SetIsInEditModeInternal", publicOrProtectedFlags);

            _isCurrentGetter = _baseClassType.GetMethod("GetIsCurrentInternal", publicOrProtectedFlags);
            _isCurrentSetter = _baseClassType.GetMethod("SetIsCurrentInternal", publicOrProtectedFlags);

        }

        public static Func<IList<IColumnInfo>, int, ListItemBase> CreateAssembly(string className, IList<IColumnInfo> propertires)
        {
            var assemblyName = $"{className}.dll";
            var assemblyBuilder = GetAssemblyBuilder(assemblyName);

            var typeBuilder = GetType(GetModule(assemblyBuilder), className);
            AddConstructor(typeBuilder);
            foreach (var property in propertires)
            {
                if (property.DataType == _stringType[0])
                    AddProperty(typeBuilder, property.UniqueName, _stringType, _stringExtensionPropertyGetter, _stringInstancePropertySetter);
                if (property.DataType == _intType[0])
                    AddProperty(typeBuilder, property.UniqueName, _intType, _intExtensionPropertyGetter, _intInstancePropertySetter);
                if (property.DataType == _boolType[0])
                    AddProperty(typeBuilder, property.UniqueName, _boolType, _boolExtensionPropertyGetter, _boolInstancePropertySetter);
                if (property.DataType == _datetimeType[0])
                    AddProperty(typeBuilder, property.UniqueName, _datetimeType, _datetimeExtensionPropertyGetter, _datetimeInstancePropertySetter);
                if (property.DataType == _chartType[0])
                    AddProperty(typeBuilder, property.UniqueName, _chartType, _chartExtensionPropertyGetter, _chartInstancePropertySetter);
                AddCellCustomisationProperties(typeBuilder, property.UniqueName);
            }

            typeBuilder.CreateType();
#if DEBUG
            assemblyBuilder.Save(assemblyName);
#endif
            return GenerateObjectExpression(assemblyName);
        }

        public static Func<IList<IColumnInfo>, int, ListItemBase> GenerateObjectExpression(string assemblyName)
        {
            var containerAssembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(assembly => assembly.GetName().Name == assemblyName);
            var paramTypes = new[] { Expression.Parameter(ConstructorParameterTypeList[0]),
                Expression.Parameter(ConstructorParameterTypeList[1]) };
            return Expression.Lambda<Func<IList<IColumnInfo>, int, ListItemBase>>
                             (Expression
                             .New(containerAssembly.DefinedTypes.First().GetConstructor(ConstructorParameterTypeList), paramTypes)
                             , paramTypes)
                             .Compile();
        }

        private static AssemblyBuilder GetAssemblyBuilder(string assemblyName)
        {
            var assembly = new AssemblyName(assemblyName);
            var currentDomain = AppDomain.CurrentDomain;
            var builder = currentDomain.DefineDynamicAssembly(assembly, AssemblyBuilderAccess.RunAndSave);

            return builder;
        }

        private static ModuleBuilder GetModule(AssemblyBuilder asmBuilder)
        {
            var name = asmBuilder.GetName().Name;
            return asmBuilder.DefineDynamicModule(name.Substring(0, name.LastIndexOf('.', name.Length - 1)), name);
        }

        private static TypeBuilder GetType(ModuleBuilder modBuilder, string className)
        {
            return modBuilder.DefineType(
                className,
                TypeAttributes.Public | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit,
                _baseClassType, _baseInterfaceTypeList);

        }

        private static void AddConstructor(TypeBuilder typeBuilder)
        {
            var constructorBuilder = typeBuilder.DefineConstructor(
                MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, CallingConventions.Standard,
                ConstructorParameterTypeList);

            var constructorIL = constructorBuilder.GetILGenerator();
            constructorIL.Emit(OpCodes.Ldarg_0);
            constructorIL.Emit(OpCodes.Ldarg_1);
            constructorIL.Emit(OpCodes.Ldarg_2);
            constructorIL.Emit(OpCodes.Call, _baseClassConstructorInfo);
            constructorIL.Emit(OpCodes.Ret);

        }

        private static void AddProperty(TypeBuilder typeBuilder, string propertyName, Type[] T,
            MethodInfo instancePropertyGetter, MethodInfo instancePropertySetter)
        {
            var field = typeBuilder.DefineField($"_{propertyName}", T[0], FieldAttributes.Private);
            var propertyBuilder = typeBuilder.DefineProperty(propertyName, PropertyAttributes.HasDefault, T[0], null);

            var getMethod = typeBuilder.DefineMethod($"get_{propertyName}",
                MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, T[0], Type.EmptyTypes);
            var getMethodIL = getMethod.GetILGenerator();

            getMethodIL.Emit(OpCodes.Ldarg_0);
            getMethodIL.Emit(OpCodes.Ldfld, field);
            getMethodIL.Emit(OpCodes.Ret);


            var setMethod = typeBuilder.DefineMethod($"set_{propertyName}",
                MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, null, T);

            var setMethodIL = setMethod.GetILGenerator();

            setMethodIL.Emit(OpCodes.Ldarg_0);
            setMethodIL.Emit(OpCodes.Ldarg_0);
            setMethodIL.Emit(OpCodes.Ldflda, field);
            setMethodIL.Emit(OpCodes.Ldarg_1);
            setMethodIL.Emit(OpCodes.Ldstr, propertyName);
            setMethodIL.Emit(OpCodes.Call, instancePropertySetter);
            setMethodIL.Emit(OpCodes.Ret);

            propertyBuilder.SetGetMethod(getMethod);
            propertyBuilder.SetSetMethod(setMethod);
        }

        private static void AddDynamicProperty(TypeBuilder typeBuilder, string propertyName, Type[] T,
            MethodInfo instancePropertyGetter, MethodInfo instancePropertySetter)
        {
            var propertyBuilder = typeBuilder.DefineProperty(propertyName, PropertyAttributes.HasDefault, T[0], null);

            var getMethod = typeBuilder.DefineMethod($"get_{propertyName}",
                MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, T[0], Type.EmptyTypes);
            var getMethodIL = getMethod.GetILGenerator();

            getMethodIL.Emit(OpCodes.Ldarg_0);
            getMethodIL.Emit(OpCodes.Ldstr, propertyName);
            getMethodIL.Emit(OpCodes.Call, instancePropertyGetter);
            getMethodIL.Emit(OpCodes.Ret);


            var setMethod = typeBuilder.DefineMethod($"set_{propertyName}",
                MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, null, T);

            var setMethodIL = setMethod.GetILGenerator();

            setMethodIL.Emit(OpCodes.Ldarg_0);
            setMethodIL.Emit(OpCodes.Ldarg_1);
            setMethodIL.Emit(OpCodes.Ldstr, propertyName);
            setMethodIL.Emit(OpCodes.Call, instancePropertySetter);
            setMethodIL.Emit(OpCodes.Ret);

            propertyBuilder.SetGetMethod(getMethod);
            propertyBuilder.SetSetMethod(setMethod);
        }

        private static void AddCellCustomisationProperties(TypeBuilder typeBuilder, string propertyName)
        {
            AddDynamicProperty(typeBuilder, $"Foreground_{propertyName}", _stringType, _foregroundGetter, _foregroundSetter);
            AddDynamicProperty(typeBuilder, $"Background_{propertyName}", _stringType, _backgroundGetter, _backgroundSetter);
            AddDynamicProperty(typeBuilder, $"IsEnabled_{propertyName}", _boolType, _isEnabledGetter, _isEnabledSetter);
            AddDynamicProperty(typeBuilder, $"IsReadOnly_{propertyName}", _boolType, _isReadOnlyGetter, _isReadOnlySetter);
            AddDynamicProperty(typeBuilder, $"IsInEditMode_{propertyName}", _boolType, _isInEditModeGetter, _isInEditModeSetter);
            AddDynamicProperty(typeBuilder, $"IsCurrent_{propertyName}", _boolType, _isCurrentGetter, _isCurrentSetter);
        }


    }

}
