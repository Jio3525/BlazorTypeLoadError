namespace TypeLoadError;

public readonly struct One {
    public readonly Generic<Two> Child;
}

public readonly struct Two {
    // Commenting this gets rid of the TypeLoadException
    public readonly One Child;
}

public readonly struct Generic<T> { }
