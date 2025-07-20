#pragma once
#ifdef LINE_EXPORTS
#define LINE_API __declspec(dllexport)
#else
#define LINE_API __declspec(dllimport)
#endif

class LINE_API Line
{
public:
	void DrawLine();
};

