#pragma once

#include "IItem.h"

namespace DnD {

class Item
    : public IItem
{
public:
    // Inherited via IItem
    virtual int getWeight() const override;
    virtual std::string getName() const override;

    void setWeight(int weight);

private:
    int m_weight{};
};

} // namespace DnD