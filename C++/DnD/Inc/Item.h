#pragma once

#include "IItem.h"

namespace DnD {

class Item
    : public IItem
{
public:
    Item(const std::string& name, int weight = 0);

    // Inherited via IItem
    virtual int getWeight() const override;
    virtual std::string getName() const override;

    void setWeight(int weight);

private:
    std::string m_name;
    int m_weight{};
};

} // namespace DnD