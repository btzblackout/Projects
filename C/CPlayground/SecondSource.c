/*
#include <stdio.h>
#include <stdint.h>

// Function prototypes
void displayBinary(uint16_t num);
uint32_t convertVirtualToPhysical(uint32_t virtualAddr, uint16_t pageSize, uint32_t* pageTable);

int main() {
    // Prompt the user for the page size (4095 or 8191)
    uint16_t pageSize;
    do {
        printf("Enter the page size (4095 or 8191): ");
        scanf_s("%hu", &pageSize);
    } while (pageSize != 4095 && pageSize != 8191);

    // Display the page size as binary and hexadecimal
    printf("Page Size (Binary): ");
    displayBinary(pageSize);
    printf("\nPage Size (Hexadecimal): 0x%04X\n", pageSize);

    // Emulate the page table using a C array
    uint32_t pageTable[1024]; // Assuming a 1M address space and 1K page table entries

    // Populate the page table with entries to support the specified page size
    for (int i = 0; i < 1024; i++) {
        pageTable[i] = i * pageSize;
    }

    // Prompt the user for a hexadecimal virtual memory address
    uint32_t virtualAddr;
    printf("Enter a hexadecimal virtual memory address (between 0x00000000 and 0x000FFFFF): ");
    scanf_s("%x", &virtualAddr);

    // Convert the virtual memory address to a physical memory address
    uint32_t physicalAddr = convertVirtualToPhysical(virtualAddr, pageSize, pageTable);

    // Display the input virtual memory address and the resultant physical memory address
    printf("Virtual Memory Address (Hexadecimal): 0x%08X\n", virtualAddr);
    if (physicalAddr == 0xFFFFFFFF) {
        printf("Resultant Physical Memory Address: Currently On Disk.\n");
    }
    else {
        printf("Resultant Physical Memory Address: 0x%08X\n", physicalAddr);
    }

    return 0;
}

// Function to display a decimal number as a 16-bit binary number
void displayBinary(uint16_t num) {
    for (int i = 15; i >= 0; i--) {
        printf("%d", (num >> i) & 1);
    }
}

// Function to convert virtual memory address to physical memory address
uint32_t convertVirtualToPhysical(uint32_t virtualAddr, uint16_t pageSize, uint32_t* pageTable) {
    // Extract page number and offset from the virtual address
    uint16_t page = virtualAddr / pageSize;
    uint16_t offset = virtualAddr % pageSize;

    // Check if the virtual memory address is within the physical memory address space
    if (page >= 512) {
        // Address is outside the physical memory address space
        return 0xFFFFFFFF; // Indicate that the page is currently on disk
    }

    // Calculate the physical memory address
    uint32_t physicalAddr = pageTable[page] + offset;
    return physicalAddr;
}
*/
