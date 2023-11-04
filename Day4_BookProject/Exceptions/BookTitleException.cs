using Day4_BookProject.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Exceptions;
public class BookTitleException : Exception
{
    public BookTitleException(string title) : base(Messages.BookTitleExceptionMessage(title)) { }
    
}
