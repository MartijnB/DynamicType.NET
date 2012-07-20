DynamicType.NET

A .NET toolkit to make it easier to handle dynamic data.

Copyright (c) 2012 iCept Media. All rights reserved.

- DynamicConversion

Convert a primitype datatype to another primitype datatype, but prevent impossible 
conversions. (Strings that doesn't contain only numeric values can't be converted 
to a int for example)

- DynamicValue

A data type can hold 1 primitype value and implements all basic operators to 
manipulate the value. For example: 10 + "10" = 20, "10"++ = 11 or "10" + 10 = 
"1010". Impossible operations like 10 + "a" are prevented and result in a 
exception.

- DynamicExpandoContainer

A ExpandoObject replacement that instead of a Exception returns a DynamicValue 
object initialised to null when a not existing property is requested.

Notes

- Decimal, double and float parsing depends on the current culture. Using the 
wrong culture can result in unexpected results. (If , is the decimal separator
in the current culture, parsing 10.0 will result in 100,0!)

- The type of the value you operating on remains the same. This can result in a
loss of precision: 4 + 4.1 = 8.

- This library was developed as part of a PoC. Documentation and Unit Tests are
missing, but since a large part of the code is generated and the API is very simple,
there isn't IMO a very high need for it. If there is actually demand for it, we can
alway decide again about it. Or submit a pull request @ GitHub ;).

Requirements

.NET 4.0+

The latest stable Mono should also work but is not tested. Earlier versions of 
.NET are not possible since they lack the dynamic support.

License

DynamicType.NET is dual licensed BSD / LGPL.
 
See License.txt for more information.

