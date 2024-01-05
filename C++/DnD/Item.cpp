#include "Item.h"

namespace DnD {

void Item::setWeight(int weight)
{
    m_weight = weight;
}

std::string Item::getName() const
{
    return m_name;
}

Item::Item(const std::string& name)
    : m_name(name)
{
}

int Item::getWeight() const
{
    return m_weight;
}

} // namespace DnD