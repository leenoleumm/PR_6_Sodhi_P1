Результат работы приложения:

![Результат работы приложения](https://github.com/leenoleumm/PR_6_Sodhi/blob/master/pic1.png)

Окно обозревателя тестов:

![Обозреватель тестов](https://github.com/leenoleumm/PR_6_Sodhi/blob/master/pic2.png)

## Вывод о проведенном тестировании

В ходе тестирования было создано 4 модульных теста: два для метода Debit и два для метода Credit.

Тест Debit_WithValidAmount_UpdatesBalance проверяет корректное списание средств. Тест Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange проверяет выброс исключения при попытке снять сумму больше баланса.

Тест Credit_WithValidAmount_UpdatesBalance проверяет корректное пополнение счета. Тест Credit_WhenAmountIsNegative_ShouldThrowArgumentOutOfRange проверяет выброс исключения при попытке пополнить счет на отрицательную сумму.

Все тесты завершились успешно. Причина успешного выполнения: код метода Debit был исправлен (вместо сложения теперь вычитание), а метод Credit изначально работал корректно. Также были добавлены константы для сообщений об ошибках, что улучшило обработку исключений.
