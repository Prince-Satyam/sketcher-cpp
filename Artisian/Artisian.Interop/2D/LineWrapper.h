#pragma once
#include "2D/Line.h"

public ref class LineWrapper
{
public:
   LineWrapper();
   ~LineWrapper();
   void Draw();
private:
   Line* pLine;  // Pointer to C++ Line class
};
