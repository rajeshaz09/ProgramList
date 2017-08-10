using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace ProgramList.TelerikPOC.Models
{
    public static class RunTimeTypeHelper
    {
        private static Type _baseClassType;
        private static Type[] _baseInterfaceTypeList;
        public static Type[] ConstructorParameterTypeList;
        private static ConstructorInfo _baseClassConstructorInfo;

        private static Type[] _stringType;
        private static Type[] _intType;
        private static Type[] _boolType;
        private static Type[] _datetimeType;
        private static Type[] _chartType;

        private static MethodInfo _instancePropertyGetter;
        private static MethodInfo _instancePropertySetter;

        private static MethodInfo _stringInstancePropertyGetter;
        private static MethodInfo _stringInstancePropertySetter;

        private static MethodInfo _intInstancePropertyGetter;
        private static MethodInfo _intInstancePropertySetter;

        private static MethodInfo _boolInstancePropertyGetter;
        private static MethodInfo _boolInstancePropertySetter;

        private static MethodInfo _datetimeInstancePropertyGetter;
        private static MethodInfo _datetimeInstancePropertySetter;

        private static MethodInfo _chartInstancePropertyGetter;
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

        static RunTimeTypeHelper()
        {
            _stringType = new Type[] { typeof(string) };
            _intType = new Type[] { typeof(int) };
            _boolType = new Type[] { typeof(bool) };
            _datetimeType = new Type[] { typeof(DateTime?) };
            _chartType = new Type[] { typeof(ChartModel) };

            _baseClassType = typeof(ListItemBase);
            _baseInterfaceTypeList = new Type[] { typeof(INotifyPropertyChanged) };
            ConstructorParameterTypeList = new Type[] { typeof(IList<GridViewBoundColumnBase>), _intType[0] };
            _baseClassConstructorInfo = _baseClassType.GetConstructor(ConstructorParameterTypeList);


            var runtimeModelBaseType = typeof(RunTimeModelBase);
            var publicOrProtectedFlags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
            _instancePropertyGetter = runtimeModelBaseType.GetMethod("GetValue", publicOrProtectedFlags);
            _instancePropertySetter = runtimeModelBaseType.GetMethod("SetValue", publicOrProtectedFlags);

            _stringInstancePropertyGetter = _instancePropertyGetter.MakeGenericMethod(_stringType);
            _stringInstancePropertySetter = _instancePropertySetter.MakeGenericMethod(_stringType);

            _intInstancePropertyGetter = _instancePropertyGetter.MakeGenericMethod(_intType);
            _intInstancePropertySetter = _instancePropertySetter.MakeGenericMethod(_intType);

            _boolInstancePropertyGetter = _instancePropertyGetter.MakeGenericMethod(_boolType);
            _boolInstancePropertySetter = _instancePropertySetter.MakeGenericMethod(_boolType);

            _datetimeInstancePropertyGetter = _instancePropertyGetter.MakeGenericMethod(_datetimeType);
            _datetimeInstancePropertySetter = _instancePropertySetter.MakeGenericMethod(_datetimeType);

            _chartInstancePropertyGetter = _instancePropertyGetter.MakeGenericMethod(_chartType);
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

        public static void CreateAssembly(string className, IList<GridViewBoundColumnBase> propertires)
        {
            var assemblyName = $"{className}.dll";
            var assemblyBuilder = GetAssemblyBuilder(assemblyName);

            var typeBuilder = GetType(GetModule(assemblyBuilder), className);
            AddConstructor(typeBuilder);
            foreach (var property in propertires)
            {
                if (property.DataType == _stringType[0])
                    AddProperty(typeBuilder, property.UniqueName, _stringType, _stringInstancePropertyGetter, _stringInstancePropertySetter);
                if (property.DataType == _intType[0])
                    AddProperty(typeBuilder, property.UniqueName, _intType, _intInstancePropertyGetter, _intInstancePropertySetter);
                if (property.DataType == _boolType[0])
                    AddProperty(typeBuilder, property.UniqueName, _boolType, _boolInstancePropertyGetter, _boolInstancePropertySetter);
                if (property.DataType == _datetimeType[0])
                    AddProperty(typeBuilder, property.UniqueName, _datetimeType, _datetimeInstancePropertyGetter, _datetimeInstancePropertySetter);
                if (property.DataType == _chartType[0])
                    AddProperty(typeBuilder, property.UniqueName, _chartType, _chartInstancePropertyGetter, _chartInstancePropertySetter);
                AddCellCustomisationProperties(typeBuilder, property.UniqueName);
            }

            typeBuilder.CreateType();
#if DEBUG
            assemblyBuilder.Save(assemblyName);
#endif
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
            var propertyBuilder = typeBuilder.DefineProperty(propertyName, PropertyAttributes.HasDefault, T[0], null);

            var getMethod = typeBuilder.DefineMethod("get_" + propertyName,
                MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, T[0], Type.EmptyTypes);
            var getMethodIL = getMethod.GetILGenerator();

            getMethodIL.Emit(OpCodes.Ldarg_0);
            getMethodIL.Emit(OpCodes.Ldstr, propertyName);
            getMethodIL.Emit(OpCodes.Call, instancePropertyGetter);
            getMethodIL.Emit(OpCodes.Ret);


            var setMethod = typeBuilder.DefineMethod("set_" + propertyName,
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
            AddProperty(typeBuilder, $"Foreground_{propertyName}", _stringType, _foregroundGetter, _foregroundSetter);
            AddProperty(typeBuilder, $"Background_{propertyName}", _stringType, _backgroundGetter, _backgroundSetter);
            AddProperty(typeBuilder, $"IsEnabled_{propertyName}", _boolType, _isEnabledGetter, _isEnabledSetter);
            AddProperty(typeBuilder, $"IsReadOnly_{propertyName}", _boolType, _isReadOnlyGetter, _isReadOnlySetter);
            AddProperty(typeBuilder, $"IsInEditMode_{propertyName}", _boolType, _isInEditModeGetter, _isInEditModeSetter);
            AddProperty(typeBuilder, $"IsCurrent_{propertyName}", _boolType, _isCurrentGetter, _isCurrentSetter);
        }


    }

}
