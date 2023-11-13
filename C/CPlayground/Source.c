#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#include <stdint.h>

// The page table should represent a virtual memory address space if 1M bytes  (0x000FFFFF)
// with a system that has a physical memory address size of 512K bytes (0x7ffff), which
// is located at 0x00000000 and 0x0007FFFF.
#define PAGE_TABLE_MAX_SIZE 0x000FFFFF
#define PHYSICAL_MAX_SIZE 0x0007FFFF

void ConvertToBinary(uint16_t number)
{
	// Display the page size to the console as a 16-bit binary number that displays each binary digit as 1 or 0
	// with the last significant bit on the right side of the output.
	printf("The binary equivalent of the number %d is ", number);

	for (int i = 15; i >= 0; i--)
	{
		// This leaves off the unnecessary 0's at the beginning.
		if (((number >> i) & 1) != 0)
		{
			// Using bitwise operators to print the binary number.
			printf("%d", (number >> i) & 1);
		}
	}

	printf(".\n");
}

void ConvertToHex(uint16_t number)
{
	// Also display the page size to the console as a hexadecimal number.
	// Use the %x format specifier with 0 - this will print just the data without any padding.
	printf("The hexadecimal equivalent of the number %d is 0x%0X\n", number, number);
}

// Emulate a page table using a C array that supports the user specified page table size
// (you may create C arrays to handle a page table for both page sizes).
uint16_t* CreatePageTableArray(uint16_t pageSize)
{
	// Get teh pages (this will be the array size).
	uint16_t numOfPages = PAGE_TABLE_MAX_SIZE / pageSize + 1;
	
	// Create the pageTableArray using malloc so when the method is over the array persists.
	uint16_t* pageTableArray = (uint16_t*)malloc(numOfPages * sizeof(uint16_t));
	
	// Return the array.
	return pageTableArray;
}

uint16_t* CreatePhysicalMemoryArray(uint16_t pageSize)
{
	// Get the pages (this will be the array size).
	uint16_t numOfPages = PHYSICAL_MAX_SIZE / pageSize + 1;
	
	// Create the physicalMemoryArray using malloc so when the method is over the array persists.
	uint16_t* physicalMemoryArray = (uint16_t*)malloc(numOfPages * sizeof(uint16_t));
	
	// Return the array.
	return physicalMemoryArray;
}

void PopulatePageTable(uint16_t* pageTableArray, uint16_t pageSize)
{
	for (uint16_t i = 0; i < PAGE_TABLE_MAX_SIZE / pageSize; i++)
	{
		// If i < page size of physical memory array then it is valid 
		// and we set the value to the physical memory array's page number.
		if (i < PHYSICAL_MAX_SIZE / pageSize)
		{
			pageTableArray[i] = i;
		}
		// i is outside the physical memory array
		else
		{
			pageTableArray[i] = 0;
		}
	}
}

uint32_t ConvertVirtualToPhysical(uint32_t virtualAddress, uint16_t* pageTableArray, uint16_t pageSize)
{
	// Get the page number and offset
	uint16_t pageNumber = virtualAddress / pageSize;
	uint16_t offset = virtualAddress % pageSize;

	// Check if the page number is in physical memory.
	if (pageNumber > PHYSICAL_MAX_SIZE / pageSize)
	{
		// If the virtual memory address does not fit into the physical memory address simply display that the result is "Currently On Disk"
		printf("The page you are looking for is currently on disk and not in memory.\n");
		return 0x000FFFFF;
	}
	else
	{
		uint32_t physicalAddressLocation = pageTableArray[pageNumber] + offset;
		return physicalAddressLocation;
	}
}
int main()
{
	uint16_t* pageTableArray;
	uint16_t* physicalMemoryArray;

	// The page size needs to be a 16 bit int.
	uint16_t pageSize = 0;

	// Prompt the user for a decimal number that will be used as the page size.
	// Valid page sizes can either be 4095 (4K bytes) or 8191 (8K bytes).
	while (pageSize != 4095 && pageSize != 8191)
	{
		printf("Please enter a page size,  valid numbers are 4095 or 8191: \n");
		scanf_s("%hu", &pageSize);
	}

	// Convert the number to binary.
	ConvertToBinary(pageSize);

	// Convert the number to hexadecimal.
	ConvertToHex(pageSize);

	// Create the appropriate pageTableArray array.
	pageTableArray = CreatePageTableArray(pageSize);

	// Create the appropriate physical memory array
	physicalMemoryArray = CreatePhysicalMemoryArray(pageSize);
	
	// Populate the page table with the appropriate page table entrees to support the specfied page size
	// and the physical memory address space.
	PopulatePageTable(pageTableArray, pageSize);

	// Prompt the user for a hexadecimal virtual memory address (between 0x00000000 and 0x000FFFFF), which will be converted
	// to a physical memory address.
	// Run the program with at least 10 different virtual memory addresses to validate all functionality of yoru program, including addresses that can be mapped
	// to physical memory and some that are on disk.
	
	uint32_t hexEntered;
	for (int i = 0; i < 10; i++)
	{
		printf("\nEnter a hexadecimal virtual memory address between 0x00000000 and 0x000FFFFF.\n");
		int c;
		while ((c = getchar()) != '\n' && c != EOF);
		scanf_s("%x", &hexEntered);

		// Display to the console the input virtual memory address as a hexadecimal number.
		// The ConvertToHex method takes an uint16 and this is a uint32 so we will print here instead of calling the method.
		printf("The hexadecimal number you entered is 0x%08X\n", hexEntered);

		// Convert the virtual memory address to a physical memory address using the user specified page size and a populated page table.
		uint32_t physicalMemoryLocation = ConvertVirtualToPhysical(hexEntered, pageTableArray, pageSize);

		// Display to the console the resultant physical memory address as a hexadecimal number.
		if (physicalMemoryLocation != 0x000FFFFF)
		{
			printf("The requested physical memory address linked to the virtual memory address provided is 0x%08X\n", physicalMemoryLocation);
		}
	}

	free(pageTableArray);
	free(physicalMemoryArray);

	return 0;
}



