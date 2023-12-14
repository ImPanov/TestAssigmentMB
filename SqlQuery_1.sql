Select [NameProduct],[NameCategory] From Products
LEFT JOIN [CategoriesProducts] on [Products].[Id] = [CategoriesProducts].[ProductId]
JOIN [Categories] on [Categories].[Id] = [CategoriesProducts].[CategoryId];