#pragma once

#include <string>

namespace DnD {

class IItem
{
public:
    virtual ~IItem() = default;

    virtual int getWeight() const = 0;
    virtual std::string getName() const = 0;

};

} // namespace DnD