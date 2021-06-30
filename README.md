# PatternSingleton

1. Паттерн Синглтон - гарантирует, что у класса есть только один экземпляр, и предоставляет глобальную точку доступа к нему.

2. Lazy Singleton : 
Достоинства: простота + потокобезопасность + «ленивость»!
Недостаток: доступна только в .NET 4.0+

3. Паттерн Одиночка гарантирует, что в приложении существует не более одного экземпляра данного класса.

4. Паттерн Одиночка также предоставляет глобальную точку доступа к этому экземпляру.

5. В Java глобальные переменные фактически представляют собой статические ссылки на объекты. У подобного использования глобальных переменных имеется пара недостатков. Один уже упоминался ранее: немедленное создание экземпляра вместо отложенного. Но мы должны помнить о предназначении этого паттерна: он должен обеспечить существование только одного экземпляра класса и глобальный доступ к нему. Глобальная переменная обеспечивает второе, но не первое. Кроме того, глобальные переменные вынуждают разработчиков загрязнять пространство имен множеством глобальных ссылок на мелкие объекты. Синглетным классам этот недостаток не присущ, хотя возможны и другие злоупотребления.