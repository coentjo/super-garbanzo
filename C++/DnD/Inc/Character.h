#pragma once

#include <memory>

#include "ICharacter.h"

namespace DnD {

class Character
    : public ICharacter
{
public:
    Character();
    virtual ~Character() = default;

    void setHealth(int health);
    void addHealth(int health);

private:
    int m_health{};
};

} // namespace DnD