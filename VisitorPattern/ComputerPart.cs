﻿namespace VisitorPattern
{
    public interface ComputerPart
    {
        void accept(ComputerPartVisitor computerPartVisitor);
    }
}
