#include "../pch.h"
#include "LineWrapper.h"

LineWrapper::LineWrapper() {
   pLine = new Line();  // Initialize the Line object
}

LineWrapper::~LineWrapper() {
   if (pLine != nullptr) {
      delete pLine;  // Clean up the Line object
      pLine = nullptr;
   }
}

void LineWrapper::Draw() {
   this->pLine->DrawLine();  // Call the native C++ function
}
