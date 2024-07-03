/*
Imagine you need to add author information to your Book class. Instead of extending an Author class,
integrate it using composition. Explain why composition might be more appropriate than inheritance 
in this scenario.
*/

/*
Composition is more appropriate than inheritance in this scenario because composition is more 
flexible than inheritance. Composition allows you to add functionality to an object without 
having to modify the original class.
*/

class compBook{
    public string name{get;set;}
    public string isbn{get;set;}
    public CompAuthor author{get; set;}
}

class CompAuthor{
    public string author{get; set;}
    //here we can change all the things and make all the differences according to ourselves in composition.
}

class InBook{
    public string name{get;set;}
    public string isbn{get;set;}
}

class InAuthor : InBook{
    public string author{get; set;}
    // in inheritence we do get flexibility, but we are not as flexible as composition
}