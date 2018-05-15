# BaseDatabase.OnNewCommittedTransaction method (1 of 2)

Adds a listener that is invoked when there is a new committed transaction

```csharp
public IDisposable OnNewCommittedTransaction(Action<DataEventTransaction> listener)
```

| parameter | description |
| --- | --- |
| listener | The lambda to call when there is a new committed [`DataEventTransaction`](../../Butterfly.Core.Database.Event/DataEventTransaction.md) |

## Return Value

An IDisposable that allows removing the listener by calling Dispose()

## See Also

* class [DataEventTransaction](../../Butterfly.Core.Database.Event/DataEventTransaction.md)
* class [BaseDatabase](../BaseDatabase.md)
* namespace [Butterfly.Core.Database](../../Butterfly.Core.md)

---

# BaseDatabase.OnNewCommittedTransaction method (2 of 2)

Adds a listener that is invoked when there is a new committed transaction

```csharp
public IDisposable OnNewCommittedTransaction(Func<DataEventTransaction, Task> listener)
```

| parameter | description |
| --- | --- |
| listener | The lambda to call when there is a new committed [`DataEventTransaction`](../../Butterfly.Core.Database.Event/DataEventTransaction.md) |

## Return Value

An IDisposable that allows removing the listener by calling Dispose()

## See Also

* class [DataEventTransaction](../../Butterfly.Core.Database.Event/DataEventTransaction.md)
* class [BaseDatabase](../BaseDatabase.md)
* namespace [Butterfly.Core.Database](../../Butterfly.Core.md)

<!-- DO NOT EDIT: generated by xmldocmd for Butterfly.Core.dll -->