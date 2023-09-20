﻿namespace Factory_Method
{
    public interface IDeveloper
    {
        //Создатель объявляет фабричный метод, который должен возвращать новые объекты продуктов.
        //Важно, чтобы тип результата совпадал с общим интерфейсом продуктов.
        IVehicle Create();
    }
}