#include <iostream>
#include <cstdlib>
#include <stdio.h>
#include <thread>
#include <Windows.h>

using namespace std;

void task1(int index){
	while (true) {
		cout << "hello" << "\n" << endl;
	}
}

int main() {
	HANDLE hTimer = NULL;
	LARGE_INTEGER liDueTIME;
	int second;
	int numberOfthreads;

	//promt a user to enter numbers
	cout << "PLease enter a number of threads\n" << endl;
	cin >> numberOfthreads;
	cout << "PLease enter time(sec) when you want to run threads\n" << endl;
	cin >> second;
	
	//set timeout
	liDueTIME.QuadPart = -10000000 * second;

	//create waitable timer
	hTimer = CreateWaitableTimer(NULL, true, "WaitableTimer");
	if (!hTimer) {
		cout << "CreateWaitableTimer function failed\n Error: " + GetLastError() << endl;
		return 1;
	}

	//set a timer with timeout 
	if (!SetWaitableTimer(hTimer, &liDueTIME, 0, NULL, NULL, 0)) {
		cout << "SetWaitableTimer function failed\n Error: " + GetLastError() << endl;
		return 1;
	}

	if (WaitForSingleObject(hTimer, INFINITE) != WAIT_OBJECT_0) {
		cout << "WaitForSingleObject() failed, error: " + GetLastError() << endl;
		return 1;
	}

	system("pause");
	return 0;
}