# UnitTestingStaticsSample
Just a stupid simple sample of implementing unit tests on static methods.

In this sample, I created a method that accesses a shared object, in this case a cache. Having static methods using a shared object during tests could have unexpected behaviors (probably not in this sample that is too simplified).

A solution would be to implement all the logic in a "normal" non static class, following the usual DI approach, able to receive the cache as a constructor argument (or even instantiate it internally). Implementing tests on this class is the usual stuff.

Finally, the static class, that'll be helpful if we don't want to inject an instance of the logic containing class everywhere, could just create it's own internal instance and be used as a proxy.