/// <summary>
/// Name:       Lab 0
/// Purpose:    building multithread and each thread count a number and display it      
/// Author:     Gisu Kim, A00959494
/// Date:       2017-10-10
/// Updated by: 2017-10-10
/// Based On:   Lab01
/// What the superviosr should know: N/A

#include <iostream>
#include <stdio.h>
#include <thread>
#include <Windows.h>  /*  Windows-specific header file  */
#include <chrono>	/* a flexible collection of types that track time with varying degrees of precision */
#include <string>
#include <time.h>

#define _CRT_SECURE_NO_WARNINGS

using namespace std;
using namespace std::chrono;


/// <summary>
/// thread function, each one counts a number till the timer is out
/// </summary>
void threadFuntion(system_clock::time_point timeout, int threadIndex){
	int count = 0;
	while (timeout > chrono::system_clock::now()) {
		cout << count++ << endl;
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
	
	/* setup time with current time*/
	system_clock::time_point timeout = system_clock::now();
	/* define timeout time with second that user enter and current time */
	timeout = timeout + seconds(second);
	
	time_t startTime;
	startTime = system_clock::to_time_t(system_clock::now());
	
	cout << "Threads start at: " << ctime(&startTime) << endl;

	/* loop through and create a number of threads and let them run the function*/
	for (int i = 0; i < numberOfthreads - 1; i++) {
		try {
			int index = i;
			thread t{ threadFuntion, timeout, index};
			t.detach();
		}
		catch (...) {
			throw;
		}
	}

	time_t endTime;
	endTime = system_clock::to_time_t(system_clock::now());
	cout << "-------------------------------------------------------------------" << endl;
	cout << "Threads end at: " << ctime(&endTime) << endl;

	
	system("pause");
	return 0;
}