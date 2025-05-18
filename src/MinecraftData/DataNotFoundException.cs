
using System.Text;

namespace MinecraftData;

[Serializable]
internal class DataNotFoundException(string dataType, string edition, string version) : Exception($"Data type '{dataType}' not available for {edition} {version}")
{
}