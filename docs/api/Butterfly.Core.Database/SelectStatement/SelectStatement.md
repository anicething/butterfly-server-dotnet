# SelectStatement constructor (1 of 3)

```csharp
public SelectStatement(IDatabase database, string sql, int overrideLimit = -1)
```

## See Also

* interface [IDatabase](../IDatabase.md)
* class [SelectStatement](../SelectStatement.md)
* namespace [Butterfly.Core.Database](../../Butterfly.Core.md)

---

# SelectStatement constructor (2 of 3)

```csharp
public SelectStatement(SelectStatement sourceSelectStatement, string overrideWhereClause, 
    bool ignoreOrderBy)
```

## See Also

* class [SelectStatement](../SelectStatement.md)
* namespace [Butterfly.Core.Database](../../Butterfly.Core.md)

---

# SelectStatement constructor (3 of 3)

```csharp
public SelectStatement(IDatabase database, string selectClause, string fromClause, 
    string whereClause, string orderByClause, int limit = -1)
```

## See Also

* interface [IDatabase](../IDatabase.md)
* class [SelectStatement](../SelectStatement.md)
* namespace [Butterfly.Core.Database](../../Butterfly.Core.md)

<!-- DO NOT EDIT: generated by xmldocmd for Butterfly.Core.dll -->