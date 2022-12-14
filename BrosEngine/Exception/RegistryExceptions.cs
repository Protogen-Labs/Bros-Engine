using BrosEngine.Registry;

namespace BrosEngine.Exception.Registry;

public class RegistrySpotTakenException<T> : System.Exception {
    public RegistrySpotTakenException(ContentRegistry<T> registry, IdentifiableString id)
        : base("Registry " + registry + " already has " + id +" registered.") {}
}