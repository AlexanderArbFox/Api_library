В случае, если возникает ошибка на первом этапе:
Install-Package EntityFramework -IncludePrerelease

### Для добавления функционала миграций:
enable-migrations

### Создать миграцию

```
add-migration <n_a_m_e Migrations>
```

### Обновляем миграцию:
update-database