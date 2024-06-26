﻿using System;

namespace PersonInfo;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private const int NAME_MIN_LENGTH = 3;

    public string FirstName
    {
        get { return _firstName; }
        private set
        {
            if (value.Length < NAME_MIN_LENGTH)
            {
                throw new ArgumentException($"First name cannot contain fewer than {NAME_MIN_LENGTH} symbols!");
            }

            _firstName = value;
        }
    }

    public string LastName
    {
        get { return _lastName; }

        private set
        {
            if (value.Length < NAME_MIN_LENGTH)
            {
                throw new ArgumentException($"Last name cannot contain fewer than 3 symbols!");
            }

            _lastName = value;
        }
    }

    public int Age
    {
        get { return _age; }

        private set
        {
            if (value < NAME_MIN_LENGTH)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }

            _age = value;
        }
    }

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }


    public override string ToString()
    {
        return $"{this._firstName} {this._lastName} is {this._age} years old.";
    }

}
