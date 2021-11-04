# Creates task directory from argument sol with class library names from argument tests. Eg: ./script 0-add MyMath
# ./unittest_meow.sh InventoryManagement InventoryLibrary 0
if [ $# -eq 3 ];
then
        classlib="$2"
        tests="$2".Tests
        sol="$1"
        new='  <PropertyGroup>\n    <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>';
        old='  <PropertyGroup>';
        
        dotnet new sln -n $1
        sudo chmod u+x "$1".sln
        mkdir "$2"
        cd "$2"
        dotnet new classlib 
        mv Class1.cs "$3".cs
        sudo chmod u+x "$2".cs && sudo chmod u+x "$2".csproj
        sed -i "s@^$old@$new@" "$2".csproj
        cd ..
        dotnet sln add "$2"/"$2".csproj
        mkdir "$tests"
        cd "$tests"
        dotnet new nunit
        mv UnitTest1.cs "$tests".cs
        sudo chmod u+x *
        
        dotnet add reference */"$2"/"$tests".csproj
        cd ..
        dotnet sln add *Test*/*.csproj
else
        echo "Usage: ./unittest_meow.sh <solution> <classlibrary> <class_name>"
fi
