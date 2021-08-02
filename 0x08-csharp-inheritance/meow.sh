# example usage: ./meow.sh 0-meow. Must still remove namespace
if [ $# -eq 1 ];
then
    prog_name="$1".cs;
    new='  <PropertyGroup>\n    <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>';
    old='  <PropertyGroup>';
    dotnet new console -o $1;
    cd "$1";
    mv Program.cs $prog_name;
    sed -i "s@^$old@$new@" "$1".csproj;
else
    echo "Usage: ./mktest <file name>"
fi
